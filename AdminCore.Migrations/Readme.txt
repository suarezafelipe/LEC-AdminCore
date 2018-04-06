/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author: Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    April 2018
 * Description:     Documentation of the Migrations Project
 */

1. When trying to run the usual migration command:

	add-migration <name of migration>
		- or -
	update-database

You will encounter the error:

	More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands	


2. In order to fix this, you must specify "MigrationsContext" as such:

	add-migration <name of migration> -Context MigrationsContext
		- and -
	update-database -Context MigrationsContext		

And it will work.

