﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("85f27334-092d-49df-9814-5f68605d3fae")>

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class toystoredbEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new toystoredbEntities object using the connection string found in the 'toystoredbEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=toystoredbEntities", "toystoredbEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new toystoredbEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "toystoredbEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new toystoredbEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "toystoredbEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property Products() As ObjectSet(Of Product)
        Get
            If (_Products Is Nothing) Then
                _Products = MyBase.CreateObjectSet(Of Product)("Products")
            End If
            Return _Products
        End Get
    End Property

    Private _Products As ObjectSet(Of Product)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToProducts(ByVal product As Product)
        MyBase.AddObject("Products", product)
    End Sub

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="toystoredbModel", Name:="Product")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Product
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Product object.
    ''' </summary>
    ''' <param name="id">Initial value of the Id property.</param>
    ''' <param name="name">Initial value of the Name property.</param>
    ''' <param name="description">Initial value of the Description property.</param>
    ''' <param name="price">Initial value of the Price property.</param>
    Public Shared Function CreateProduct(id As Global.System.Int32, name As Global.System.String, description As Global.System.String, price As Global.System.Decimal) As Product
        Dim product as Product = New Product
        product.Id = id
        product.Name = name
        product.Description = description
        product.Price = price
        Return product
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Id() As Global.System.Int32
        Get
            Return _Id
        End Get
        Set
            If (_Id <> Value) Then
                OnIdChanging(value)
                ReportPropertyChanging("Id")
                _Id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Id")
                OnIdChanged()
            End If
        End Set
    End Property

    Private _Id As Global.System.Int32
    Private Partial Sub OnIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Name() As Global.System.String
        Get
            Return _Name
        End Get
        Set
            OnNameChanging(value)
            ReportPropertyChanging("Name")
            _Name = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("Name")
            OnNameChanged()
        End Set
    End Property

    Private _Name As Global.System.String
    Private Partial Sub OnNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Description() As Global.System.String
        Get
            Return _Description
        End Get
        Set
            OnDescriptionChanging(value)
            ReportPropertyChanging("Description")
            _Description = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("Description")
            OnDescriptionChanged()
        End Set
    End Property

    Private _Description As Global.System.String
    Private Partial Sub OnDescriptionChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnDescriptionChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Price() As Global.System.Decimal
        Get
            Return _Price
        End Get
        Set
            OnPriceChanging(value)
            ReportPropertyChanging("Price")
            _Price = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Price")
            OnPriceChanged()
        End Set
    End Property

    Private _Price As Global.System.Decimal
    Private Partial Sub OnPriceChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OnPriceChanged()
    End Sub

    #End Region
End Class

#End Region

