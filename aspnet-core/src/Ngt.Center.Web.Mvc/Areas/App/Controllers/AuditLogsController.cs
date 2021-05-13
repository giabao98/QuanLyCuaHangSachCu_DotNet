using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Auditing;
using Ngt.Center.Auditing.Dto;
using Ngt.Center.Authorization;
using Ngt.Center.Web.Areas.App.Models.AuditLogs;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : CenterControllerBase
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public AuditLogsController(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> EntityChangeDetailModal(EntityChangeListDto entityChangeListDto)
        {
            var output = await _auditLogAppService.GetEntityPropertyChanges(entityChangeListDto.Id);

            var viewModel = new EntityChangeDetailModalViewModel(output, entityChangeListDto);

            return PartialView("_EntityChangeDetailModal", viewModel);
        }
    }
}