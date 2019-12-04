RSMFValidatorSampleCode
=======

## Introduction

The RSMFValidatorSampleCode project illustrates how to leverage the RSMF Validator library provided by Relativity.  The RSMF JSON schema is included in the RSMFManifestSchema directory.

## Desktop Client EXE

The Desktop Client, RSMFValidationDesktop, was created on top of the Console Application RSMFValidationSampleCode. Build and run it from the GUI. It can be found under .\rsmf-validator-samples-master\RSMFValidationDesktop\bin\Debug\netcoreapp3.0\

Note: My contribution is the WPF app, not the Console app.

1. Run the RSMFValidationDesktop Application
2. Press 'Select RSMF Sample to Validate' button, this will open a file dialog
3. Select any file within the target folder you want to test, if there are multiple json files, just choose one at random, it'll run against them all 
4. Validation will happen in the text box below the button and can be found in .\rsmf-validator-samples-master\RSMFValidationDesktop\bin\Debug\netcoreapp3.0\rsmf.validation.log for later viewing. 

## Build

To build the sample code, open the RSMFValidatorSampleCode.sln in Visual Studio 2015.  Restore the Nuget packages which will download and install the RSMF Validator library.  Build in release or debug mode.

## RSMF sample files

A short walkthrough with invalid RSMF sample files is included in the Documentation directory.  See RSMFValidatorSampleCode.pdf.
