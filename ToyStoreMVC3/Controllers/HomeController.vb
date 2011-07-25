Namespace ToyStoreMVC3
    Public Class HomeController
        Inherits System.Web.Mvc.Controller
        Private _entities As New ProductDBContext

        '
        ' GET: /Home

        Function Index() As ActionResult
            
            Return View(_entities.Products.ToList())
        End Function

        '
        ' GET: /Home/Details/5

        Function Details(ByVal id As Integer) As ActionResult
            Dim result = (From p In _entities.Products _
                          Where p.Id = id _
                          Select p).FirstOrDefault()
            Return View(result)
        End Function

        '
        ' GET: /Home/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Home/Create

        <HttpPost()> _
        Function Create(ByVal productToCreate As Product) As ActionResult
            Try
                ' TODO: Add insert logic here
                _entities.Products.Add(productToCreate)
                _entities.SaveChanges()
                Return (RedirectToAction("Index"))
            Catch
                Return View()
            End Try
        End Function
        
        '
        ' GET: /Home/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Dim productToEdit = (From p In _entities.Products _
                                 Where p.Id = id _
                                 Select p).FirstOrDefault()
            Return View(productToEdit)
        End Function

        '
        ' POST: /Home/Edit/5

        <HttpPost()> _
        Function Edit(ByVal productToEdit As Product) As ActionResult
            Try
                ' TODO: Add update logic here
                Dim originalProduct = _entities.Products.Find(productToEdit.Id)
                UpdateModel(originalProduct)
                _entities.SaveChanges()
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /Home/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Dim productToDelete = (From p In _entities.Products _
                                 Where p.Id = id _
                                 Select p).FirstOrDefault()
            Return View(productToDelete)
        End Function

        '
        ' POST: /Home/Delete/5

        <HttpPost()> _
        Function Delete(ByVal productToDelete As Product) As ActionResult
            Try
                ' TODO: Add delete logic here
                Dim originalProduct = _entities.Products.Find(productToDelete.Id)
                _entities.Products.Remove(originalProduct)
                _entities.SaveChanges()
                _entities.SaveChanges()
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace