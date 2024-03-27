# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import math

def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
#הנחה: הקלט של הרוחב המתקבל במשולש הוא גדול מ- 3
print("press 1 for rectangle 2 for triangular ans 3 for exit");
option=int(input());
while(option!=3):
     high=int(input("insert high"));
     width=int(input("insert width"));
     # rectangle
     if option==1:
         if abs(high-width)>5:
             print("the rectangle of the area: ",high*width);
         if abs(high - width) <= 5:
             print("the rectangle of the scope: ", high*2+width*2);

     #triangular
     if option==2:
         option_2=int(input("you have tow options: click 1 for calculate the scope of the triangle or 2 for print the triangular"));
         if option_2==1:
             hypotenuse=math.sqrt(math.pow(high,2)+math.pow((width)/2.0,2));
             print("the scope of the triangle: ",width+2*hypotenuse);
         if option_2==2:
              if(width%2==0 or width>high*2):
                  print("It is not possible to print such a triangle");
              else:
                  numbers_of_options=int((width/2)-1);
                  num_of_print_every_row=int((high-2)/numbers_of_options);
                  left=int((high-2)%numbers_of_options);
                  num_of_print_in_row=3;
                  print(" "*int((width-1)/2)+"*");
                  for num in range(numbers_of_options):
                      if(num==0):
                          for i in range(num_of_print_every_row+left):
                              print(" "*int((width-num_of_print_in_row)/2)+"*"*num_of_print_in_row);
                          num_of_print_in_row+=2;
                      else:
                          for i in range(num_of_print_every_row):
                              print(" "*int((width-num_of_print_in_row)/2)+"*" * num_of_print_in_row);
                          num_of_print_in_row += 2;
                  print("*"*width);

     print("press 1 for rectangle 2 for triangular ans 3 for exit");
     option = int(input());




