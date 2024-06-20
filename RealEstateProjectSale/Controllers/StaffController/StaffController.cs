using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleBusinessObject.DTO.Create;
using RealEstateProjectSaleBusinessObject.ViewModels;
using RealEstateProjectSaleServices.IServices;

namespace RealEstateProjectSale.Controllers.StaffController
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffServices _staffServices;
        private readonly IMapper _mapper;

        public StaffController(IStaffServices staffServices, IMapper mapper)
        {
            _staffServices = staffServices;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllStaff()
        {
            try
            {
                if (_staffServices.GetAllStaff() == null)
                {
                    return NotFound();
                }
                var staffs = _staffServices.GetAllStaff();
                var response = _mapper.Map<List<StaffVM>>(staffs);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffByID(Guid id)
        {
            var staff = _staffServices.GetStaffByID(id);

            if (staff != null)
            {
                var responese = _mapper.Map<StaffVM>(staff);

                return Ok(responese);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult AddNewStaff(StaffCreateDTO staff)
        {
            try
            {
                var _staff = _mapper.Map<Staff>(staff);
                _staffServices.AddNewStaff(_staff);

                return Ok("Create Staff Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
