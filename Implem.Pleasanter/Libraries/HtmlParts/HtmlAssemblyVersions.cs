﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.Models;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System;
namespace Implem.Pleasanter.Libraries.HtmlParts
{
    public static class HtmlAssemblyVersions
    {
        public static string AssemblyVersions(this HtmlBuilder hb)
        {
            var ss = new SiteSettings();
            return hb
                .Template(
                    ss: ss,
                    verType: Versions.VerTypes.Latest,
                    methodType: BaseModel.MethodTypes.NotSet,
                    allowAccess: true,
                    useBreadcrumb: false,
                    useTitle: false,
                    useNavigationMenu: true,
                    action: () => hb
                        .Div(id: "Versions", action: () => hb
                            .Div(action: () => hb
                                .Span(action: () => hb
                                    .Text(text: Parameters.General.HtmlTitle)))
                            .Div(action: () => hb
                                .Span(action: () => hb
                                    .Text(text: Displays.Version()))
                                .Span(action: () => hb
                                    .Text(text: Environments.AssemblyVersion)))
                            .Div(action: () => hb
                                .Span(action: () => hb
                                    .A(
                                        href: Parameters.General.HtmlCopyrightUrl,
                                        action: () => hb
                                            .Raw(text: Parameters.General.HtmlCopyright.Params(
                                                DateTime.Now.Year))))))
                        .MainCommands(ss: ss, siteId: 0, verType: Versions.VerTypes.Latest))
                .ToString();
        }
    }
}