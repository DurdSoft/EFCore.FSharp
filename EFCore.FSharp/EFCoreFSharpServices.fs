﻿namespace Bricelam.EntityFrameworkCore.FSharp

open Microsoft.EntityFrameworkCore.Design
open Microsoft.EntityFrameworkCore.Migrations.Design
open Microsoft.EntityFrameworkCore.Scaffolding
open Microsoft.EntityFrameworkCore.Scaffolding.Internal
open Microsoft.Extensions.DependencyInjection

open Bricelam.EntityFrameworkCore.FSharp.Scaffolding
open Bricelam.EntityFrameworkCore.FSharp.Scaffolding.Internal
open Bricelam.EntityFrameworkCore.FSharp.Migrations.Design
open Bricelam.EntityFrameworkCore.FSharp.Internal

type EFCoreFSharpServices() =
    interface IDesignTimeServices with
        member __.ConfigureDesignTimeServices(services: IServiceCollection) =
            services
                .AddSingleton<ICSharpHelper, FSharpHelper>()
                .AddSingleton<ICSharpEntityTypeGenerator, FSharpEntityTypeGenerator>()
                .AddSingleton<ICSharpDbContextGenerator, FSharpDbContextGenerator>()
                .AddSingleton<IModelCodeGenerator, FSharpModelGenerator>()
                .AddSingleton<ICSharpMigrationOperationGenerator, FSharpMigrationOperationGenerator>()
                .AddSingleton<ICSharpSnapshotGenerator, FSharpSnapshotGenerator>()
                .AddSingleton<IMigrationsCodeGenerator, FSharpMigrationsGenerator>()
                .AddSingleton<IMigrationsScaffolder, FSharpMigrationsScaffolder>()
                .AddSingleton<FSharpMigrationsGeneratorDependencies>() |> ignore
