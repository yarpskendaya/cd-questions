# Given/Arrange Questions

## Data
- How do you instantiate data with only the relevant properties specified?
- Right now, I have a static Create class which I populate with factory methods that lend the ability to instantiate objects with only the properties I'm interested in. Any critiques?
```
namespace TheCompany.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModelEditorTests
    {
        private static readonly IDocument _stubDoc = BimCreate.Document();

        public class EditFamilyInstance : ModelEditorTests
        {
            [Test]
            public void WhenInstanceIsNotOfFamily_Throws()
            {
                FamilyAssembly assembly = Create.FamilyAssembly(family: "TheRightFamily");
                IFamilyInstance instance = BimCreate.FamilyInstance(family: "WrongFamily");
                Assert.Throws<FamilyInstanceEditException>(() =>
                {
                    new ModelEditor().EditFamilyInstance(_stubDoc, assembly, Transform.Zero, instance);
                });
            }
        }
    }
}
```

- Are there any common patterns you use?
    - Object Mother Pattern?
    - Test Data Builder Pattern?

## SUT
- In the London approach, you´d new up the SUT with its required services stubbed out. How is this generally done in the Classical approach?
- Do you mainly do London or Classical in unit tests?
- Having production versions of the dependencies would entail a dependency graph that might get a little deeper than one layer.
How is this kept only to the relevant details for the test?

### DI System
- Is the DI system used to get an instance of the SUT?
- Do you manipulate the DI container to replace some dependencies with test doubles?
- Do you specifically test the DI container?