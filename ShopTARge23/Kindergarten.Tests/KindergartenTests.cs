using System;
using Xunit;
using ShopTARge23.Core.Domain;

namespace ShopTARge23.Tests
{
    public class KindergartenTests
    {
        // test 1:
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {

            var kindergarten = new Kindergarten();


            Assert.NotNull(kindergarten);
            Assert.Null(kindergarten.Id);
            Assert.Null(kindergarten.GroupName);
            Assert.Equal(0, kindergarten.ChildrenCount);
            Assert.Null(kindergarten.KindergartenName);
            Assert.Null(kindergarten.Teacher);
            Assert.Equal(default(DateTime), kindergarten.CreatedAt);
            Assert.Equal(default(DateTime), kindergarten.UpdatedAt);
        }

        // test 2:
        [Fact]
        public void Properties_ShouldSetAndGetValues()
        {

            var kindergarten = new Kindergarten();
            var expectedId = Guid.NewGuid();
            var expectedGroupName = "Lasteaed Aaaa";
            var expectedChildrenCount = 14;
            var expectedKindergartenName = "Lasteaed";
            var expectedTeacher = "Õpetaja";


            kindergarten.Id = expectedId;
            kindergarten.GroupName = expectedGroupName;
            kindergarten.ChildrenCount = expectedChildrenCount;
            kindergarten.KindergartenName = expectedKindergartenName;
            kindergarten.Teacher = expectedTeacher;


            Assert.Equal(expectedId, kindergarten.Id);
            Assert.Equal(expectedGroupName, kindergarten.GroupName);
            Assert.Equal(expectedChildrenCount, kindergarten.ChildrenCount);
            Assert.Equal(expectedKindergartenName, kindergarten.KindergartenName);
            Assert.Equal(expectedTeacher, kindergarten.Teacher);
        }
        // test 3:
        [Fact]
        public void CreatedAt_ShouldBeSetToCurrentTime()
        {

            var kindergarten = new Kindergarten();
            var currentTime = DateTime.UtcNow;
            kindergarten.CreatedAt = currentTime;


            var createdAt = kindergarten.CreatedAt;


            Assert.True((createdAt - currentTime).TotalSeconds < 1);
        }
        // test 4:
        [Fact]
        public void UpdatedAt_ShouldBeSetToCurrentTime()
        {

            var kindergarten = new Kindergarten();
            var currentTime = DateTime.UtcNow;
            kindergarten.UpdatedAt = currentTime;


            var updatedAt = kindergarten.UpdatedAt;


            Assert.True((updatedAt - currentTime).TotalSeconds < 1);
        }
    }
}
