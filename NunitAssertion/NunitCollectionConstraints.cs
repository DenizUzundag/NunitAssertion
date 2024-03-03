
namespace NunitAssertion
{
    public class NunitCollectionConstraints
    {
        int[] collectionX = { 1, 3, 5, 9, 12 };
        int[] collectionY = { 1, 3, 5, 9, 12 };
        int[] collectionZ = { 4, 8, 11, 2, 6, 2 };
        int[] collectionW = null;

        [Test]
        public void HasMember()
        {
            Assert.That(collectionX, Has.Member(3));
        }

        [Test]
        public void IsEqualTo()
        {
            Assert.That(collectionX, Is.EqualTo(collectionY), "Collections are not equal");
        }

        [Test]
        public void IsNotEqualTo()
        {
            Assert.That(collectionX, Is.Not.EqualTo(collectionZ), "Collections are not equal");
        }

        [Test]
        public void CountAssertion()
        {
            Assert.That(collectionX.Count, Is.EqualTo(5));
            //Assert.That(collectionY,Has.Count(5));
        }

        [Test]
        public void ContainsAssertion()
        {
            Assert.That(collectionX, Contains.Item(3));
            Assert.That(collectionX, Does.Not.Contain(2));
        }

        [Test]
        public void GreaterThanAssertion()
        {
            // Check if all elements are greater than 0
            Assert.That(collectionZ, Is.All.GreaterThan(0));
        }

        [Test]
        public void LessThanAssertion()
        {
            // Check if all elements are less than 10
            Assert.That(collectionY, Is.All.LessThan(15));
        }

        [Test]
        public void IsNotEmpty()
        {
            Assert.That(collectionZ, Is.Not.Empty);
        }

        [Test]
        public void IsAllNotNull()
        {
            Assert.That(collectionY, Is.All.Not.Null);
        }

        [Test]
        public void IsNull()
        {
            Assert.That(collectionW, Is.Null);
        }

        [Test]
        public void UniqueItems()
        {
            Assert.That(collectionX, Is.Unique);
            Assert.That(collectionZ, Is.Not.Unique);
        }
    }
}
