﻿using Business.BaseData.OrganizationManagement;
using Business.BaseData.OrganizationManagement.Dto;
using Business.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.BaseData
{
    [Area("business")]
    [Route("api/business/orgs")]
    public class OrganizationController : BusinessController, IOrganizationAppService
    {
        private readonly IOrganizationAppService _organizationAppService;

        public OrganizationController(IOrganizationAppService organizationAppService)
        {
            _organizationAppService = organizationAppService;
        }

        [HttpPost]
        public Task<OrganizationDto> Create(CreateOrUpdateOrganizationDto input)
        {
            return _organizationAppService.Create(input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task Delete(Guid id)
        {
            return _organizationAppService.Delete(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<OrganizationDto> Get(Guid id)
        {
            return _organizationAppService.Get(id);
        }

        [HttpGet]
        [Route("all")]
        public Task<PagedResultDto<OrganizationDto>> GetAll(GetOrganizationInputDto input)
        {
            return _organizationAppService.GetAll(input);
        }

        [HttpGet]
        [Route("loadOrgs")]
        public Task<ListResultDto<OrganizationDto>> LoadAll(Guid? orgId)
        {
            return _organizationAppService.LoadAll(orgId);
        }

        [HttpGet]
        [Route("loadNodes")]
        public Task<ListResultDto<OrganizationDto>> LoadAllNodes(Guid id)
        {
            return _organizationAppService.LoadAllNodes(id);
        }

        [HttpGet]
        [Route("list")]
        public Task<PagedResultDto<OrganizationDto>> GetAllList(GetOrganizationInputDto input)
        {
            return _organizationAppService.GetAllList(input);
        }

        [HttpGet]
        [Route("parents")]
        public Task<ListResultDto<OrganizationDto>> GetAllWithParents(GetOrganizationInputDto input)
        {
            return _organizationAppService.GetAllWithParents(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<OrganizationDto> Update(Guid id, CreateOrUpdateOrganizationDto input)
        {
            return _organizationAppService.Update(id, input);
        }
    }
}
