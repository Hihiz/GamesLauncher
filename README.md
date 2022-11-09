# Код <a href="https://github.com/Hihiz/GamesLauncher/blob/development/GameLauncher/View/MainWindow.xaml">MainWindow</a>
## Пример
![p1](https://user-images.githubusercontent.com/98191494/200916163-287cfbb4-aaa4-4fde-9c5a-ce80a40b3ecc.PNG)
![p2](https://user-images.githubusercontent.com/98191494/200916167-2a042e27-8587-4587-9438-a395e928e1b2.PNG)
![p3](https://user-images.githubusercontent.com/98191494/200916172-dd1e1617-24f8-4682-bc73-fa08169c84b1.PNG)
![pp](https://user-images.githubusercontent.com/98191494/200916591-b0bc68c6-a8eb-46fc-b17b-7175718125b1.PNG)

```C#
   // Премещение окна
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
```
