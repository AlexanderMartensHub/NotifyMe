using NotifyMe.Services;
using NUnit.Framework;

namespace NotifyMeTests.ServicesTests
{
    public abstract class ConditionCheckerBaseTests
    {
        protected abstract IConditionChecker CreateInstance();
        
        [Test]
        public void CanBeInstantiated()
        {
            IConditionChecker checker = CreateInstance();

            Assert.NotNull(checker);
        }
    }
}
