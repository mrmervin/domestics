#Author:Mervin Noronha 27/09/2017 OFGEM

# Domestic Renewable Heat Incentive
This framework allows one to run selenium tests on different browsers and environments .This also take screenshot and embeds the screenshot in
the final report.Refer to documentation [here](http://www.specflow.org/plus/documentation/Tutorial:-Customising-Reports) 
for explanation of how the screenshot 
path is passed to the report.

## Important parts
##App.config
In configuration/appSettings/browser the used browser is configured.This value is changed by a ConfigFileTransformation in the
 **Default.srProfile**
In the configuration dropdown the Used Environment is configured select the required test configuration created .Eg: If you select Test
 it will now run using the App.Test.config transformations created . Using slow-cheetah which transforms xml files ar build time based on configuration

## DefaultsrProfile
Three targets one for every browser is defined here.They have a filter on the tag _Browser_\_**__{BrowserName}__**,
so only scenarios with the tag is executed in this target.

##AppDriver.cs
This driver provides you access to the appropriate Selenium Webdriver.It uses the configuration/appsettings/browser value for this.
To get access to the Selenium Webdriver,Use the initBrowser Method which get the browser instance from the Target selected in Test Explorer
 Use[Context Injection](http://www.specflow.org/documentation/Context-Injection/) to get the instance .
To access a particular Url use loadApplication method which will get the url from qa01ww\com.drhi.stepDefinitions\BaseStepDefinition.cs 
which tranforms the xml in app.config to point to the required test server.
Use [xml transforms](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.SlowCheetah-XMLTransforms) to get the instance  

##Hooks.cs
They contain methods that  are executed at various points during the test execution .

##Deployment Steps
1.ConfigFileTransformation-This sets the configuration/appsettings/browser_ to the target name

##qa01ww\com.drhi.stepDefinitions\BaseStepDefinition.cs
This file  contain methods that call the required environment stored as values in app.config 

