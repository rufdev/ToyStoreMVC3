﻿@ModelType ToyStoreMVC3.Product

@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)
    @<fieldset>
        <legend>Fields</legend>

        @Html.HiddenFor(Function(model) model.Id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Name)
            @Html.ValidationMessageFor(Function(model) model.Name)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Description)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Price)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Price)
            @Html.ValidationMessageFor(Function(model) model.Price)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

