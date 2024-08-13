# ClickOnce-DevProd-Publish-Demo
This source code demonstrates how to publish an app using ClickOnce with multiple environments profile and install both apps in computer at the same time.

## Steps to set up different behaviour for Dev and Prod app
### 1. Setup different build configurations for Dev and Prod [Optional]
Create new profile `Dev` which is a copy of `Debug` and `Prod` which is a copy of `Release`. This is only done for demo purpose. This can be used by `Debug` or `Release` configurations as well. Helpful, in cases where different behaviour is needed for different build configurations. Otherwise, 

![image](https://github.com/user-attachments/assets/162daa8c-36ff-4c5c-89a7-e2976552005e)

### 2. Setup conditional symbols for DEV [Optional]
In order to display different console message when both apps are run set conditional symbol `DEV` for `Dev` build configuration. This step is optional and only needed to test if the app you are running is running with Dev profile or from Prod profile. 

<img width="398" alt="image" src="https://github.com/user-attachments/assets/eb87049f-7f05-4b5c-af1a-34d2f3a0c8e1">

After this you can use it in `Program.cs` 

```
#if DEV
Console.WriteLine("Hello, World! (Dev)");
#else
Console.WriteLine("Hello, World! (Prod)");
#endif

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
```

### 3. Set different assembly names in the `.csproj` file 

If using `Debug` and `Release` configurations then `.csproj` file should be edited accordingly.

<img width="510" alt="image" src="https://github.com/user-attachments/assets/55f740cc-c77a-4aa8-b0e5-8b3c059ee6d5">

### 4. Setup environment specific publish profiles
In this demo we will publish the exe on our local machine in different folders for `Dev` and `Prod`. 

![image](https://github.com/user-attachments/assets/6cc265c7-1bdb-4417-a100-d899f60eec0f)

1. Set the Publish Location

   <img width="589" alt="image" src="https://github.com/user-attachments/assets/c902be9c-24d1-4dd2-8283-01a07a9a634e">
   
2. Set the option for Users to get application from 

![image](https://github.com/user-attachments/assets/a9817da2-0ae5-42c0-ad9a-c7eda7f42982)

3. Set the Auto increment of versions and set `Publisher name` and `Product name` to differentiate between `Dev` and `Prod` app during installation and in Control panel. 

<img width="512" alt="image" src="https://github.com/user-attachments/assets/735a35fd-c270-41e9-8213-754656a699d4">

<img width="532" alt="image" src="https://github.com/user-attachments/assets/11d7c1f1-a0a8-44df-9fc6-e841dffe5192">

Follow, same steps with `Prod` profile. 

![image](https://github.com/user-attachments/assets/06b88063-ed87-4d8b-b1fd-cec0bb1ade41)

![image](https://github.com/user-attachments/assets/24ceb477-f8e0-46bd-950a-d1748a056569)

4. Once the profiles are set Publish both apps in `Publish Wizard`. After publish both exe will be available in their respective folders. 

![image](https://github.com/user-attachments/assets/35fa57c1-8182-45f7-b334-f0376c634caf)

![image](https://github.com/user-attachments/assets/9523735f-ab0e-43d3-bee7-363f1be42bb1)

### 5. Output of the installation and execution of the app

When the apps are intalled we see two different apps in the `Control Panel` for `Dev` and `Prod`. This allows us to run the apps simultaneously without overriding / uninstalling the other.

![image](https://github.com/user-attachments/assets/b5f5b8d0-57b3-461a-8d91-bf008e0c67dd)

After running the apps it displays message based on the app. 

<img width="158" alt="image" src="https://github.com/user-attachments/assets/9806eaa0-e326-4a36-b0fe-5b2b446d31d4">

<img width="154" alt="image" src="https://github.com/user-attachments/assets/a828416f-2127-47a4-8635-66705409181a">











