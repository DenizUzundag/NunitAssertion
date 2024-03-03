using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssertion
{
    public class NUnitStringConstraints
    {
        string message1 = "Hello, friends! Welcome to my world.";
        string message2 = "HELLO, FRIENDS! WELCOME TO MY WORLD.";
        string message3 = string.Empty;

        [Test]
        public void StringEmpty()
        {
            //String.Empty
            Assert.That(message1, Is.Not.Empty);
            Assert.That(message3, Is.Empty);

        }

        [Test]
        public void NullOrEmpty()
        {
            //String.NullOrEmpty:
            Assert.That(message1, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void IsEqualTo()
        {
            Assert.That(message1, Is.EqualTo("Hello, friends! Welcome to my world."));
            Assert.That(message2, Is.Not.EqualTo("Hello, friends! Welcome to my world."));
            Assert.That(message2, Is.Not.EqualTo(message1));
            Assert.That(message2[0], Is.EqualTo('H'));
        }

        [Test]
        public void StartWith()
        {
            Assert.That(message1, Does.StartWith("Hello, friends!"), "Does not StartWith ");
        }

        [Test]
        public void EndWith()
        {
            Assert.That(message2, Does.EndWith("WORLD."));
            Assert.That(message2, Does.Not.EndWith("my world."));
        }

        [Test]
        public void Contains()
        {
            //String.Contain
            Assert.That(message2, Does.Contain("TO MY"));
            Assert.That(message1, Does.Not.Contain("welcome"));
            Assert.That(message1, Does.Contain("friends!").And.Contain("my"));
        }

        [Test]
        public void DoesMatch()
        {
            Assert.That(message1, Does.Match("l*l"));
        }

        [Test]
        public void LenghtControl()
        {
            //String.Length
            Assert.That(message1.Length, Is.GreaterThan(10));
        }

    }
}
