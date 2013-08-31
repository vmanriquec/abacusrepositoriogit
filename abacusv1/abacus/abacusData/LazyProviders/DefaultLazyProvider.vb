
        
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' You can edit this file as your wish.
'------------------------------------------------------------------------------

Imports System
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports abacusRules.Entities


Imports abacusRules.Objects


Imports abacusRules.Gateways


Imports abacusRules.Mappers


Imports System.Collections.Generic

Namespace LazyProviders
    Public Class DefaultLazyProvider
        Implements ILazyProvider
        Private Shared thisLock As Object = New Object()
        Private Shared _mappersCache As Dictionary(Of String, IGenericGateway)
        Private Shared ReadOnly Property MappersCache As Dictionary(Of String, IGenericGateway)
            Get
                SyncLock thisLock

                    If DefaultLazyProvider._mappersCache Is Nothing Then
                        DefaultLazyProvider._mappersCache = New Dictionary(Of String, IGenericGateway)()
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.AlmacenesObject", abacusRules.Gateways.AlmacenesGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.cargopersonalObject", abacusRules.Gateways.cargopersonalGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Categorias", abacusRules.Mappers.CategoriasMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.CategoriasObject", abacusRules.Gateways.CategoriasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Choferes", abacusRules.Mappers.ChoferesMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ChoferesObject", abacusRules.Gateways.ChoferesGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.ClieAlmacen", abacusRules.Mappers.ClieAlmacenMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ClieAlmacenObject", abacusRules.Gateways.ClieAlmacenGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ClieContactosObject", abacusRules.Gateways.ClieContactosGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Clientes", abacusRules.Mappers.ClientesMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ClientesObject", abacusRules.Gateways.ClientesGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Cotizacion", abacusRules.Mappers.CotizacionMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.CotizacionObject", abacusRules.Gateways.CotizacionGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.CotizacionDet", abacusRules.Mappers.CotizacionDetMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.CotizacionDetObject", abacusRules.Gateways.CotizacionDetGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.DistritosObject", abacusRules.Gateways.DistritosGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Factura", abacusRules.Mappers.FacturaMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.FacturaObject", abacusRules.Gateways.FacturaGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.FacturaDet", abacusRules.Mappers.FacturaDetMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.FacturaDetObject", abacusRules.Gateways.FacturaDetGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.FamiliasObject", abacusRules.Gateways.FamiliasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.FormaPagoObject", abacusRules.Gateways.FormaPagoGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Guias", abacusRules.Mappers.GuiasMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.GuiasObject", abacusRules.Gateways.GuiasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.GuiasDet", abacusRules.Mappers.GuiasDetMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.GuiasDetObject", abacusRules.Gateways.GuiasDetGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.idcrd", abacusRules.Mappers.idcrdMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.idcrdObject", abacusRules.Gateways.idcrdGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Ingresos", abacusRules.Mappers.IngresosMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.IngresosObject", abacusRules.Gateways.IngresosGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.IngresosDet", abacusRules.Mappers.IngresosDetMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.IngresosDetObject", abacusRules.Gateways.IngresosDetGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Kardex", abacusRules.Mappers.KardexMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.KardexObject", abacusRules.Gateways.KardexGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Login", abacusRules.Mappers.LoginMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.LoginObject", abacusRules.Gateways.LoginGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.MarcasObject", abacusRules.Gateways.MarcasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.MonedasObject", abacusRules.Gateways.MonedasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.MotivoSalObject", abacusRules.Gateways.MotivoSalGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.MovilesObject", abacusRules.Gateways.MovilesGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Productos", abacusRules.Mappers.ProductosMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ProductosObject", abacusRules.Gateways.ProductosGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.ProvContactos", abacusRules.Mappers.ProvContactosMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ProvContactosObject", abacusRules.Gateways.ProvContactosGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ProveedoresObject", abacusRules.Gateways.ProveedoresGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.ProvinciasObject", abacusRules.Gateways.ProvinciasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.registrodevisitas", abacusRules.Mappers.registrodevisitasMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.registrodevisitasObject", abacusRules.Gateways.registrodevisitasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.ruta", abacusRules.Mappers.rutaMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.rutaObject", abacusRules.Gateways.rutaGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Salidas", abacusRules.Mappers.SalidasMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.SalidasObject", abacusRules.Gateways.SalidasGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.SalidasDet", abacusRules.Mappers.SalidasDetMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.SalidasDetObject", abacusRules.Gateways.SalidasDetGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TCObject", abacusRules.Gateways.TCGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TipoCliProvObject", abacusRules.Gateways.TipoCliProvGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TIPOIGVObject", abacusRules.Gateways.TIPOIGVGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TipoProductoObject", abacusRules.Gateways.TipoProductoGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.tipousuarioObject", abacusRules.Gateways.tipousuarioGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.Trabajadores", abacusRules.Mappers.TrabajadoresMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TrabajadoresObject", abacusRules.Gateways.TrabajadoresGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.TransportistaObject", abacusRules.Gateways.TransportistaGateway.Instance())
                     
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Entities.usuario", abacusRules.Mappers.usuarioMapper.Instance())
                         
                        DefaultLazyProvider._mappersCache.Add("abacusRules.Objects.usuarioObject", abacusRules.Gateways.usuarioGateway.Instance())
                    
                    End If

                End SyncLock

                Return DefaultLazyProvider._mappersCache
            End Get
        End Property

        ''' <summary>
        ''' Get associated entity for this entity
        ''' </summary>
        Public Function GetEntity(ByVal child As System.Type, ByVal identifier As IUniqueIdentifiable) As IUniqueIdentifiable Implements ILazyProvider.GetEntity
            Dim genericGateway As IGenericGateway = DefaultLazyProvider.MappersCache(child.FullName)
            Return CType(genericGateway.GetOne(identifier), IUniqueIdentifiable)
        End Function

        ''' <summary>
        ''' Get collection based in the parent entity
        ''' </summary>
        Public Function GetList(child As System.Type, parent As IUniqueIdentifiable) As Object Implements ILazyProvider.GetList
            Dim genericGateway As IGenericGateway = DefaultLazyProvider.MappersCache(child.FullName)
            Return genericGateway.GetByParent(parent)
        End Function
    End Class
End Namespace


