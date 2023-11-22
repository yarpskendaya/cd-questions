public class GridCellConfiguratorTests
{
    [Test]
    public void PositionsModelRelativeToGridCell()
    {
        HouseModelAssembly model =
            Create.HouseModelAssembly(transform: Create.Transform(new Vector3(500, -10, 90)));
        GridCellAssembly grid = Create.GridCellAssembly(model.AsList());
        Vector3 cellPosition = new(-455, 77.7, 0);
        IModelConfigurator modelConfigurator = CreateModelConfigurator();
        Transform expected = new(new Vector3(45, 67.7, 90), Rotation.Zero, false);
        GridCellConfigurator gridConfigurator = CreateConfigurator(modelConfigurator);
        
        gridConfigurator.Configure(_stubDoc, grid, Create.Transform(cellPosition));

        modelConfigurator.Received().Configure(_stubDoc, model.Model, expected);
    }

    private IModelConfigurator CreateModelConfigurator()
    {
        // return stub;
    }
}

















public static class Create {}
public class GridCellConfigurator
{
    public void Configure(IDocument doc, HouseModelAssembly model, Transform transform)
    {
    }
}
public class GridCellAssembly {}
public class HouseModelAssembly {}
public class Vector3 {}
public class Rotation {}
public class Transform {}
public interface IModelConfigurator {}
