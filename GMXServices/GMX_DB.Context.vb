﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class GMXEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=GMXEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function spS_Aclaracion(id_pv As Nullable(Of Integer)) As ObjectResult(Of spS_Aclaracion_Result)
        Dim id_pvParameter As ObjectParameter = If(id_pv.HasValue, New ObjectParameter("id_pv", id_pv), New ObjectParameter("id_pv", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_Aclaracion_Result)("spS_Aclaracion", id_pvParameter)
    End Function

    Public Overridable Function spU_ActualizaFirmas(numOP As Nullable(Of Integer), tipoPersona As Nullable(Of Integer), usuFirma As String) As ObjectResult(Of Nullable(Of Integer))
        Dim numOPParameter As ObjectParameter = If(numOP.HasValue, New ObjectParameter("NumOP", numOP), New ObjectParameter("NumOP", GetType(Integer)))

        Dim tipoPersonaParameter As ObjectParameter = If(tipoPersona.HasValue, New ObjectParameter("TipoPersona", tipoPersona), New ObjectParameter("TipoPersona", GetType(Integer)))

        Dim usuFirmaParameter As ObjectParameter = If(usuFirma IsNot Nothing, New ObjectParameter("UsuFirma", usuFirma), New ObjectParameter("UsuFirma", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spU_ActualizaFirmas", numOPParameter, tipoPersonaParameter, usuFirmaParameter)
    End Function

    Public Overridable Function spS_PermisosxUSuFirma(cod_usuario As String) As ObjectResult(Of spS_PermisosxUSuFirma_Result)
        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_PermisosxUSuFirma_Result)("spS_PermisosxUSuFirma", cod_usuarioParameter)
    End Function

    Public Overridable Function spS_UsuarioFirma(tipoUsuario As Nullable(Of Integer)) As ObjectResult(Of spS_UsuarioFirma_Result1)
        Dim tipoUsuarioParameter As ObjectParameter = If(tipoUsuario.HasValue, New ObjectParameter("TipoUsuario", tipoUsuario), New ObjectParameter("TipoUsuario", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_UsuarioFirma_Result1)("spS_UsuarioFirma", tipoUsuarioParameter)
    End Function

End Class
