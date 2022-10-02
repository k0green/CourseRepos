using Garage.Controllers;
using Garage.Interfaces;
using Garage.Models;
using Moq;
using System;


namespace GarageTest
{
    public struct CarControllerTest
    {
        private readonly CarsController _sut;
        private readonly UsersController _sutus;
        private readonly Mock<IGetAllCarsService> _getAllCarsServiceMock;
        private readonly Mock<IUpdateCarService> _updateCarServiceMock;
        private readonly Mock<ICreateCarService> _createCarServiceMock;
        private readonly Mock<ICreateUserService> _createUserServiceMock;
        private readonly Mock<IDeleteCarService> _deleteCarServiceMock;
        public CarControllerTest()
        {
            _getAllCarsServiceMock = new Mock<IGetAllCarsService>();
            _updateCarServiceMock = new Mock<IUpdateCarService>();
            _createCarServiceMock = new Mock<ICreateCarService>();
            _deleteCarServiceMock = new Mock<IDeleteCarService>();
            _createUserServiceMock = new Mock<ICreateUserService>();
            _sut = new CarsController(_getAllCarsServiceMock.Object, _updateCarServiceMock.Object,  _createCarServiceMock.Object, _deleteCarServiceMock.Object);
            _sutus = new UsersController(_createUserServiceMock.Object);
        }

        [Fact]
        public async Task GetAll_ShouldReturnAllCar()
        {
            var cars = new List<CarItemModel>();
            _getAllCarsServiceMock.Setup(x => x.GetAll()).ReturnsAsync(cars);
            var result =await _sut.GetAllAsync();
            Assert.Equal(result, cars);
        }

        [Fact]
        public async Task Upadate_ShouldUpdateCar()
        {
            var request = new UpdateCarRequest
            {
                Id = 3,
                Name = "teterev",
                UserId = 2,
            };
            await _sut.UpdateAsync(request);
            _updateCarServiceMock.Verify(x => x.Update(It.IsAny<UpdateCarRequest>()), Times.Once);

        }
        [Fact]
        public async Task Create_ShouldCreateCar()
        {
            var request = new CreateCarRequest
            {
                Name = "teterev",
                UserId = 2,
            };
            await _sut.Add(request);
            _createCarServiceMock.Verify(x => x.Create(It.IsAny<CreateCarRequest>()), Times.Once);

        }
        [Fact]
        public async Task Create_ShouldCreateUser()
        {
            var request = new CreateUserRequest
            {
                Phone="+375295482673",
                Name = "igor",
            };
            await _sutus.Add(request);
            _createUserServiceMock.Verify(x => x.Create(It.IsAny<CreateUserRequest>()), Times.Once);

        }
    }
}
