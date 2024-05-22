# Prog122_L11_Notes_Week8
Creating a New Window in WPF


Static Classes
can be called without creating an instance of it

Observable Collection
Standard Requirements

Header ( Commented name, date, assignment name on MainWindow.xaml.cs )
Submisson of GitHub Repo Link
Comments
Skills Needed

How to create a New Window and open it
How to create a static class, static fields, and a static constructor
How to create, add to, and connect an Observable collection
All other previous skills from the quarter
Create a new Project

Setup your project so that you have a 2nd Window to work with.

On your main window you should have a button to open the second window.

Also on the main window you should have a list box to display names, a text box, and a button so that you can add names to your ObservableCollection ( We're using instead of a list )

On your second window you should have a list box.

Create a static class, Data, that will have a public static ObservableCollection field to hold a list of 5 names.

Create a static constructor for Data and load 5 names into your names collection in the constructor. ( Note: a static constructor cannot have an access modifier so no public )

Connect your code so the listbox in both the MainWindow and your NewWindow are accessing the same list in the data class.

Create the functionality so when you add a name from MainWindow you add it to the names list in your Data class.

If everything is properly working you should see your 5 names load on application run. The same names will appear when you open your new window. When you add a name it should auto appear in both the MainWindow and NewWindow listbox at the same time.