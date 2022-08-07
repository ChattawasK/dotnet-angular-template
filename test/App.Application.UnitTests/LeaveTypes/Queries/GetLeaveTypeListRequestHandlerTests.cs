using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using App.Application.Contracts.Persistence;
using App.Application.DTOs.LeaveType;
using App.Application.Features.LeaveTypes.Handlers.Queries;
using App.Application.Features.LeaveTypes.Requests.Queries;
using App.Application.Profiles;
using App.Application.UnitTests.Mocks;
using AutoMapper;
using Moq;
using Shouldly;
using Xunit;

namespace App.Application.UnitTests.LeaveTypes.Queries
{
    public class GetLeaveTypeListRequestHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ILeaveTypeRepository> _mockRepo;
        public GetLeaveTypeListRequestHandlerTests()
        {
            _mockRepo = MockLeaveTypeRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(c => 
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetLeaveTypeListRequestHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetLeaveTypeListRequest(), CancellationToken.None);

            result.ShouldBeOfType<List<LeaveTypeDto>>();

            result.Count.ShouldBe(3);
        }
    }
}