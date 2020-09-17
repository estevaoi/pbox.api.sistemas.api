using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.api.Controllers
{
    [Route("sistemas")]
    [ApiController]
    public class SistemaController : Controller
    {
        private readonly IApplicationServiceSistema _applicationServiceSistema;

        public SistemaController(IApplicationServiceSistema ApplicationServiceSistema)
        {
            _applicationServiceSistema = ApplicationServiceSistema;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceSistema.GetAll());
        }

        [HttpGet("{sistemaId}")]
        public ActionResult<IEnumerable<string>> Get(Guid sistemaId)
        {
            var sistemaData = _applicationServiceSistema.GetById(sistemaId);

            if (sistemaData == null)
            {
                return NoContent();
            }

            return Ok(sistemaData);
        }

        [HttpPost]
        public ActionResult Post([FromBody] SistemaDto sistemaDto)
        {
            sistemaDto.SistemaId = Guid.NewGuid();
            try
            {
                _applicationServiceSistema.Add(sistemaDto);
                return Ok(sistemaDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{sistemaId}")]
        public ActionResult Put([FromBody] SistemaDto sistemaDto, Guid sistemaId)
        {
            if (sistemaDto.SistemaId != sistemaId)
            {
                return BadRequest("Sistema ID Diferentes");
            }

            try
            {
                if (sistemaId == null)
                {
                    return BadRequest("Error");
                }

                if (sistemaDto == null)
                {
                    return NotFound();
                }
                _applicationServiceSistema.Update(sistemaDto);
                return Ok(sistemaDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("all")]
        public ActionResult PutAll([FromBody] SistemaDto sistemaDto)
        {
            try
            {
                if (sistemaDto == null)
                {
                    return NotFound();
                }
                _applicationServiceSistema.Update(sistemaDto);
                return Ok(sistemaDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] SistemaDto sistemaDto)
        {
            try
            {
                if (sistemaDto == null)
                {
                    return NotFound();
                }
                _applicationServiceSistema.Remove(sistemaDto);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}