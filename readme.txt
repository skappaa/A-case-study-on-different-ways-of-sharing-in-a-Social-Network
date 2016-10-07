Run the program in Visual Studio 2008 or higher. Make sure the folders for D3 and HTML file for displaying graph are inside project folder.
It is necessary to run python local server in order to host files. For that purpose, install python. Open command prompt and Go into ~/Debug/bin folder of project where json files are being written. Execute following python command in order to host the server:

python -m SimpleHTTPServer <port number> &

In the project, I have written code to directly open the browser with default port number set to 9000. Make sure you change the code to suitable port number that you choose for this command. 
In the project I have written code to save experiment results directly to the excel files.
I have two excel file paths specified in the code

*IMPORTANT* In form2.cs we need to change the path of the excell sheet path for windowsForm.xls and windowsForm1.xls to the appropriate path.


when you give input in form 1 , it goes to form 2 and a browser opens, I am not interested in the D3 and the browser stuff but,
1) the form2 contains strategies and their % consideration. Upon button send _ click in form 2 the results of strategies are saved in windowsForm1.xls 
 
Things to be Done, 
- When ever results are saved in windowsForm1.xls a new colum has to be created and the strategy number has to be saved which was used
