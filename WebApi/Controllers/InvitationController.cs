using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        IInvitationBll bll;

        public InvitationController(IInvitationBll bll)
        {
            this.bll = bll;
        }

        [HttpGet]
        public List<InvitationDTO> GetAll()
        {
            return  this.bll.GetAll();
        }

        [HttpGet("GetById/{InvitationId}")]
        public async Task<InvitationDTO> GetById(int InvitationId)
        {
            return await this.bll.GetById(InvitationId);
        }

        [HttpPost]
        public async Task<int> Add(InvitationDTO invitation)
        {
            return await this.bll.Add(invitation);
        }

        [HttpDelete("{InvitationId}")]
        public async Task<bool> Delete(int InvitationId)
        {
            return await this.bll.Delete(InvitationId);
        }

        [HttpGet("GetAllInvitationsToTrip/{tripId}")]
        public async Task<List<InvitationDTO>> GetAllInvitationsToTrip(int tripId)
        {
            return await bll.GetAllInvitationsToTrip(tripId);
        }
    }
}
