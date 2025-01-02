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
        public ActionResult Get()
        {
            var list=_advertiserService.GetAll() ;
            var listDto=_mapper.Map<IEnumerable<AdvertisterDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<AdvertisersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var advertister = _advertiserService.GetById(id);
            var advertisterDto=_mapper.Map<AdvertisterDTO>(advertister);
            return Ok(advertisterDto);
        }

        // POST api/<AdvertisersController>
        [HttpPost]
        public void Post([FromBody] AdvertisterPost value)
        {
            var dto = _mapper.Map<Advertiser>(value);
           _advertiserService.AddValue(dto);
        }

        // PUT api/<AdvertisersController>/5
        [HttpPut(/*"{id}"*/)]
        public void Put([FromBody] AdvertisterUpdate value)
        {
            var dto = _mapper.Map<Advertiser>(value);
            _advertiserService.PutValue( dto);
        }

        // DELETE api/<AdvertisersController>/5
        [HttpDelete("{advertisers}")]
        public void Delete(AdvertisterUpdate advertiser)
        {
            var dto = _mapper.Map<Advertiser>(advertiser);
            _advertiserService.Delete(dto);
        }
        [HttpPut("{id}/status")]
        public void Status(int id, string status)
        {
            _advertiserService.Status(id, status);
        }
    }
}
