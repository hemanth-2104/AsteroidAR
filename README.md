
# AsteroidAR

Welcome to AR Space Defender, an exciting augmented reality (AR) game built using Unity AR Foundation for the Android platform. Immerse yourself in an outer space scene where you must protect Earth from incoming asteroids and UFO saucers. Earn points and mystery prizes by successfully destroying them.

## Prerequisites

Before getting started, make sure you have the following:

- Unity 2022.3.0f1 or later versions installed on your development machine.
- Android Studio with Android SDK installed.
- An Android device running Android 7.0 (Nougat) or later, with ARCore support.
- A device capable of capturing touch or joystick input.

## Getting Started

Follow the steps below to set up the project on your local machine and deploy it to your Android device:

1. Clone the repository to your local machine:

```shell
git clone https://github.com/hemanth-2104/AsteroidAR.git
```

2. Open Unity and click on **Open** to browse to the project directory. Select the **AsteroidAR** folder and click **Open**.

3. Once the project is open, navigate to the **Scenes** folder and open the **AsteroidsGame** scene. This scene contains the main AR game setup.

4. Connect your Android device to your development machine using a USB cable.

5. In Unity, click on **File -> Build Settings**. In the Build Settings window, select **Android** as the target platform.

6. Click on **Player Settings** to open the Player Settings window. In the **Other Settings** section, configure the following settings:
   - Set the **Package Name** to a unique identifier for your application (e.g., com.yourcompany.arSpaceDefender).
   - Set the **Minimum API Level** to Android 7.0 or later.

7. In the Player Settings window, navigate to the **XR Plug-in Management** section. Enable **ARCore Supported**.

8. Click **Build and Run** to build the project and deploy it to your Android device. Unity will launch Android Studio and start the build process.

9. Once the build process completes, the AR Space Defender app will be installed on your Android device.

## Gameplay

In AR Space Defender, you are a space defender assigned with the task of protecting Earth from asteroids and UFO saucers. The objective is to destroy as many of these threats as possible. Here's how the game works:

- Upon launching the app, the AR scene will be displayed on your Android device, overlaying the real world.

- Move your device around to scan and detect a suitable flat surface for gameplay.

- Once a surface is detected, Earth will appear at the center of the scene, and asteroids and UFO saucers will start approaching.

- Use your device's touch screen or connected input device to aim and shoot at the asteroids and UFO saucers. Each successful hit will earn you points based on the target destroyed.

- Shooting a large asteroid will break it into two medium-sized asteroids. Destroying one of those pieces will break it into two small asteroids.

- Be careful! The asteroids will travel towards Earth with a small direction offset. If an asteroid collides with Earth or the player's spaceship, it will cause damage. If the player's or Earth's life reaches zero, the game will be over.

- Earn scores for destroying different targets:
  - Small Asteroid: 100 points
  - Medium Asteroid: 50 points
  - Large Asteroid: 20 points
  - UFO Saucer: 100 points

- Mystery prizes await you! Keep an eye out for special power-ups or bonuses that may appear during gameplay.

- Challenge yourself to achieve the highest score

![Scene Mockup](https://lh3.googleusercontent.com/fife/APg5EOYIhL3RVMG4pbvBw_wdqATAya_5EMQp5drYhsUWmsBDuOlJroozcUz0_RYsw0JhTZfwEnyZRnNDqS8GaGV7j0UBt9lVDmUkWyvEHJerYRoIyxWWKJafDy4sljQQwjdZ8rp-C_MhM3C_J2OgS3S6MRz_rPdtpZKeDMhXMJ2evNh_HTPLB932zTdEiVqGotxWt4gIHeVbvBmuiNagSupcuzQeX4BVZV7HoQdAoLHJ5_eEq7VEepByInXnB3JWuuWITsOFh5-JRGwQQYOZreZdM3YBh2lX3RuSdg7twGpQMvUTdMPW3Y-hIQ77CK_eFjoBD6Z1ZWwltSHnu-l5ct3cYaIEobsqVUUqNDZmdYxa7w5zd6gObAAuJbWu5S2aK7VYUD4G3I9U3POrHtwD8jYY5W14s6TK0X2J4J_2iwqGnU4rScbXjqSW2A7CDtjfcJKzVYLcfAxevBl1Q4QGvr73B4jJsb-xh7UpmU9izjoXnb_jGSohopj6nn37vciwB4E7EX2Ay_7y_w5673Cg7WRv7Zu4_gK8FferUhbGR5OohDXHAtrDE0lSX3BqWyYJoNJHTKpudY9n7cvNlYZ-RmTpC9Sz5bAjKz0KDxgQwFImhvL9iBFK2kkvrOOT-_pGswzg_JiohrfKTzUv9aS1bc7_s9dFsish8PP_gRBfkqWnwZXnzo-8D9w7C2gINN7Zg3SqihlVcy_9v06QR92CBgS7LEHvfyTWaFExRHeA7w6vak3JmjrY46DhiF0CuIHu7X7M_bsgDYYs8JBvm8Oiq4OBR7Fg_4Bfu08GE4Y9RKp12LQ_b0ndgOu2UX7tN83SabALnerxKcY37oUJhbKzBXn6IfGPNAdY9Mlu6b6j24-1cMubzT7dJvUNJoXbY8WsAi6n3bEt7tMacIY5DtbwMOY3NL8_pTkEltEzkPV3V_tkOeuFbQd-71xIOf2UPXq-ngLn6USSb_YPm6oGU_72W77_4mZa2yrGfRC8sZyaB3PoWb2CmaWAqwG-MNmF-3LEmm7p4EOGuUMrwSY3fwu9-BhoihPgmERX4CoyPU9rAQpv0jwxr9nComUhz1ecVE1xhg-egwT9M5SUDNL7EW0yAwgNGQV-i6aAwpj2jHsn_VqcHl5P9Jlwz7kn8DMoQXSOyADR2j7mBE_L-_X6G51Q_cv7XcMjNFvokcsyNb3icCqV4sWOg9XCFfi2Ionzi4zqLWrK5eaWT7E7AwpK0RUeWqzMaOdS0WwEg7B_LAAmFQGqCo-XbNK2dy8x6aFzAqkPqoc6XvY8cVJITSH0XBoki5TkQQ6lwGtR4Fz2iQv0-a_HNbD3M6JIPcqBXixE5oOQfwu2TRUHwOMNB533q7dii1YVxaBRcqfuB43IkA3-HJna1e5Q78qQ_MYvDZNSiF1Ui6GU0J9pVF06CiShHduB-b4-sUa8QAOt6_IEapnbNfXM38S96qZ6JGc020ZAgaHgs1vwP35Y6j4WXiCf---VQ8UrnUiogT9JWMazJ6XLwAOHipdrzWYyDMn4xZCRfAFd951q7jVLbf9DcY7FgmKWh0UL9TYKSNMteYinRnMzRVx7l6X8AruN_ODuUPECPbNl38hMoJQjQz7ooPrG4BmVFKj3HRMyi34mVPKFzrT4WCRFmAnNHoB9K1P7=w1920-h897)

Sence Mockup
