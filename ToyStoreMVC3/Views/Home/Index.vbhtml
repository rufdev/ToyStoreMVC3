@ModelType IEnumerable(Of ToyStoreMVC3.Product)

@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p> 
<table>
    <tr>
        <th></th>
        <th>
            Name
        </th>
        <th>
            Description
        </th>
        <th>
            Price
        </th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
        </td>
        <td>
            @item.Name
        </td>
        <td>
            @item.Description
        </td>
        <td>
            @String.Format("{0:F}", item.Price)
        </td>
    </tr>
Next

</table>

