# Lab08 - Phills Lending Library

## What is this Lab talking about ?<br />
In this lab , we should construct a simple library system , that add , borrow , and returns books , to / from the library , We will use classes , interfaces and OOP principles (inheritance) to do our work , also there two methods that do the same as Add and Borrow , which are Pack and Unpack methods.<br />

## Visuals :<br />

![Run Console app](Phils-Lending-Library/Asserts/lib.png)


## How to use the app ?
## Add a book :
To add a book , you can use Add method , that takes 4 parameters , which are title (string) , author first name (string) , author last name (string) and pages number (int) .

for Example:<br />
`Library book1 = new Library();`<br />
`book.Add("book1" , "yaman" , "ali" , 100);`<br />

## Borrow a book :
To borrow a book , you can use Borrow method , that takes 1 parameter , which is title .

for Example:<br />
`Book b = new Book();`<br />
`b = book1.Borrow("book1");`<br />


## Return a book :
To return a book , you can use Return method , that takes 1 parameter (Book) type.

for Example:<br />

`book1.Return(b);`<br />

## Pack a book :
To pack a book , you can use Pack method , that takes 1 parameter , which is Book (Book) type .<br />
for Example:<br />
`book1.Pack(b);`<br />

## UnPack a book :
To unpack a book , you can use Unpack method , that takes 1 parameter , which is Book (Book) type .<br />
for Example:<br />
`book1.Unpack(b);`
