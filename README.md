# How to load images in a cell in WinUI TreeGrid?

This example describes how to load images in a cell in WinUI TreeGrid.

You can add the image to [WinUI TreeGrid](https://www.syncfusion.com/winui-controls/treegrid) (SfTreeGrid) cell by using **TreeGridTemplateColumn**.

### XAML

``` xml
<treeGrid:SfTreeGrid Name="treeGrid"                 
                    AutoGenerateColumns="False"
                    AutoExpandMode="RootNodesExpanded"
                    ChildPropertyName="ReportsTo"
                    AllowResizingColumns="True"
                    NavigationMode="Cell" 
                    AllowEditing="True"
                    SelfRelationRootValue="-1"
                    SelectionMode="Single" 
                    ItemsSource="{Binding EmployeeDetails}" >
    <treeGrid:SfTreeGrid.Columns>
        <treeGrid:TreeGridTextColumn MappingName="FirstName"/>
        <treeGrid:TreeGridTextColumn MappingName="LastName"/>
        <treeGrid:TreeGridNumericColumn HeaderText="Employee ID" MappingName="ID" />
        <treeGrid:TreeGridTextColumn MappingName="Title"/>
        <treeGrid:TreeGridTemplateColumn HeaderText="Country" MappingName="ImageLink">
            <treeGrid:TreeGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Grid>
                        <Image Width="30"
                               Height="20"
                               Source="{Binding ImageLink,
                                                Converter={StaticResource converter}}" />
                    </Grid>
                </DataTemplate>
            </treeGrid:TreeGridTemplateColumn.CellTemplate>
        </treeGrid:TreeGridTemplateColumn>
    </treeGrid:SfTreeGrid.Columns>
</treeGrid:SfTreeGrid>
```

### C#

``` csharp
class StringToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        string imageName = value.ToString();
        if (imageName == "US.jpg")
        {
            Uri uri = new Uri("ms-appx:///Images/US.jpg");
            BitmapImage image = new BitmapImage(uri);
            return image;
        }

        else if (imageName == "UK.jpg")
        {
            Uri uri1 = new Uri("ms-appx:///Images/UK.jpg");
            BitmapImage image = new BitmapImage(uri1);
            return image;
        }

        else
        {
            Uri uri1 = new Uri("ms-appx:///Images/Japan.jpg");
            BitmapImage image = new BitmapImage(uri1);
            return image;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
```