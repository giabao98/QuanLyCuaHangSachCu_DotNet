using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization;
using Ngt.Center.Authorization.Permissions;
using Ngt.Center.Authorization.Permissions.Dto;
using Ngt.Center.Authorization.Roles;
using Ngt.Center.Authorization.Roles.Dto;
using Ngt.Center.Authorization.Users;
using Ngt.Center.Security;
using Ngt.Center.Web.Areas.App.Models.Roles;
using Ngt.Center.Web.Areas.App.Models.Users;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : CenterControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly UserManager _userManager;
        private readonly IUserLoginAppService _userLoginAppService;
        private readonly IRoleAppService _roleAppService;
        private readonly IPermissionAppService _permissionAppService;
        private readonly IPasswordComplexitySettingStore _passwordComplexitySettingStore;

        public UsersController(
            IUserAppService userAppService,
            UserManager userManager,
            IUserLoginAppService userLoginAppService,
            IRoleAppService roleAppService,
            IPermissionAppService permissionAppService,
            IPasswordComplexitySettingStore passwordComplexitySettingStore)
        {
            _userAppService = userAppService;
            _userManager = userManager;
            _userLoginAppService = userLoginAppService;
            _roleAppService = roleAppService;
            _permissionAppService = permissionAppService;
            _passwordComplexitySettingStore = passwordComplexitySettingStore;
        }

        public async Task<ActionResult> Index()
        {
            var roles = new List<ComboboxItemDto>();

            if (IsGranted(AppPermissions.Pages_Administration_Roles))
            {
                var getRolesOutput = await _roleAppService.GetRoles(new GetRolesInput());
                roles = getRolesOutput.Items.Select(r => new ComboboxItemDto(r.Id.ToString(), r.DisplayName)).ToList();
            }

            roles.Insert(0, new ComboboxItemDto("", ""));

            var permissions = _permissionAppService.GetAllPermissions().Items.ToList();

            var model = new UsersViewModel
            {
                FilterText = Request.Query["filterText"],
                Roles = roles,
                Permissions = ObjectMapper.Map<List<FlatPermissionDto>>(permissions).OrderBy(p => p.DisplayName).ToList(),
                OnlyLockedUsers = false
            };

            return View(model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users_Create, AppPermissions.Pages_Administration_Users_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(long? id)
        {
            var output = await _userAppService.GetUserForEdit(new NullableIdDto<long> { Id = id });
            var viewModel = ObjectMapper.Map<CreateOrEditUserModalViewModel>(output);
            viewModel.PasswordComplexitySetting = await _passwordComplexitySettingStore.GetSettingsAsync();

            return PartialView("_CreateOrEditModal", viewModel);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users_ChangePermissions)]
        public async Task<PartialViewResult> PermissionsModal(long id)
        {
            var output = await _userAppService.GetUserPermissionsForEdit(new EntityDto<long>(id));
            var viewModel = ObjectMapper.Map<UserPermissionsEditViewModel>(output);
            viewModel.User = await _userManager.GetUserByIdAsync(id); ;
            return PartialView("_PermissionsModal", viewModel);
        }

        public async Task<PartialViewResult> LoginAttemptsModal()
        {
            var output = await _userLoginAppService.GetRecentUserLoginAttempts();
            var model = new UserLoginAttemptModalViewModel
            {
                LoginAttempts = output.Items.ToList()
            };
            return PartialView("_LoginAttemptsModal", model);
        }
    }
}