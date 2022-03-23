# Instruction for Connecting Application to DB

- Step 1: Make sure you have Sql server installed
- Step 2: Open the app.config file under the Contact_list startup project
- Step 3: change connection string's server name with your server name
- Step 4: Open Visual Studio->Tools->NugetPackage Manager-> Packege Manager Console 
- Step 5: In the opened window select DefaultProject ‘Contact_list.DAL’
- Step 6: type ‘update-database’ and press Enter(to have seed data)
- Step 4: Run the application

##### System should create the database in your specified server and fill the seed data for test in it.