@ModelType ToyStoreMVC3.Product

@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Fields</legend>

    <div class="display-label">Name</div>
    <div class="display-field">@Model.Name</div>

    <div class="display-label">Description</div>
    <div class="display-field">@Model.Description</div>

    <div class="display-label">Price</div>
    <div class="display-field">@String.Format("{0:F}", Model.Price)</div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using


