using System;
using services;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReceive_1_AfterCall_Add_On_Service()
        {
            Moq.Mock<IRepository<User>> repository = new Moq.Mock<IRepository<User>>();
            IService<User> service = new Service<User>(repository.Object);
            repository.Setup((r) => r.Add(Moq.It.IsAny<User>())).Returns(1);
            var expected = 1;
            var actual = service.Add(Moq.It.IsAny<User>());
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldReceive_1_AfterCall_Add_On_Service_Using_Repository_Implementation()
        {

            IRepository<User> repo = new RepositoryFactory<User>().Get();
            IService<User> service = new Service<User>(repo);
            var expected = 1;
            var actual = service.Add(Moq.It.IsAny<User>());
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Should_Get_An_User_RepositoryInstance()
        {

            var expected = typeof(Repository<User>);
            var actual = new RepositoryFactory<User>().Get().GetType();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_A_Company_RepositoryInstance()
        {

            var expected = typeof(Repository<Company>);
            var actual = new RepositoryFactory<Company>().Get().GetType();
            Assert.Equal(expected, actual);
        }
    }
}
