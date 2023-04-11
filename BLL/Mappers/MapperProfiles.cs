using AutoMapper;
using BossAzAPI.DTOs.EnumValueDTOs;
using BossAzAPI.DTOs.JobDTOs;
using BossAzAPI.DTOs.PhoneDTOs;
using BossAzAPI.DTOs.ResumeDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.BLL.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            #region Job Mappings

            CreateMap<Job, JobToListDto>();
            CreateMap<Job, JobByIdDto>();
            CreateMap<JobToAddDto, Job>();
            CreateMap<JobToUpdateDto, Job>();

            #endregion

            #region Resume Mappings

            CreateMap<Resume, ResumeToListDto>();
            CreateMap<Resume, ResumeByIdDto>();
            CreateMap<ResumeToAddDto, Resume>();
            CreateMap<ResumeToUpdateDto, Resume>();

            #endregion

            #region EnumValue Mappings

            CreateMap<EnumValue, EnumValueToListDto>();

            #endregion

            #region Phone Mappings

            CreateMap<PhoneToAddDto, Phone>();
            CreateMap<Phone, PhoneToListDto>();

            #endregion
        }
    }
}
