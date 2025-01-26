using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Yad2.CORE.DTOs;
using Yad2.CORE.Models;
using Yad2.CORE.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        
        private readonly IAdvertiserService _advertiserService;
        private readonly IMapper _mapper;
        // GET: api/<advertisersController>
        public AdvertiserController(IAdvertiserService context,IMapper mapper)
        {
            _advertiserService = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list=await _advertiserService.GetAllAsync() ;
            var listDto=_mapper.Map<IEnumerable<AdvertisterDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<AdvertisersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var advertister = await _advertiserService.GetByIdAsync(id);
            var advertisterDto=_mapper.Map<AdvertisterDTO>(advertister);
            return  Ok(advertisterDto);
        }

        // POST api/<AdvertisersController>
        [HttpPost]
        public async Task Post([FromBody] AdvertisterPost value)
        {
            var dto = _mapper.Map<Advertiser>(value);
           await _advertiserService.AddValueAsync(dto);
        }

        // PUT api/<AdvertisersController>/5
        [HttpPut(/*"{id}"*/)]
        public async void Put([FromBody] AdvertisterUpdate value)
        {
            var dto = _mapper.Map<Advertiser>(value);
           await _advertiserService.PutValueAsync( dto);
        }

        // DELETE api/<AdvertisersController>/5
        [HttpDelete("{advertisers}")]
        public async Task Delete(AdvertisterUpdate advertiser)
        {
            var dto = _mapper.Map<Advertiser>(advertiser);
           await _advertiserService.DeleteAsync(dto);
        }
        [HttpPut("{id}/status")]
        public async Task Status(int id, string status)
        {
           await _advertiserService.Status(id, status);
        }
    }
}
