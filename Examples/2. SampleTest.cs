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

        CreateConfigurator(modelConfigurator).Configure(_stubDoc, grid, Create.Transform(cellPosition));

        modelConfigurator.Received().Configure(_stubDoc, model.Model, expected);
    }
}