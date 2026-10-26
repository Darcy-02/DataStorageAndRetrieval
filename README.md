I have 3 Scripts: 

the first one is PlanetData.cs which is where i created a scriptable Objects with 3 variables of int, float, string data types.



the main idea comes from the idea of the cosmos. mass of planets is a primary factor that helps us know the number of moons it can hold. In our case, I started small with our planet earth which only has 1 moon.



then I proceeded to connect my scriptable object with a MonoBehaviour (Planet.cs) because i wanted to keep my logic separate from my data



For PlayerPrefs. data is stored like a dictionary 

**"score = PlayerPrefs.GetInt("Score", 0);"**

Here, my player is able to tweek the score, volume and name. to check if it all worked, i changed the  values in game mode then closed game mode and restarted it again to find my latest changes unchanged 



this is because playerprefs saves read/write at runtime by saving permanently accross game sessions 

hence **"ShowSavedData();"** which loads and displays data



**"PlayerPrefs.Save();"** this saves data. making PlayerPrefs different from ScriptableObjects because unlike PlayerPrefs, Any changes made to a ScriptableObject during game mode resets when you close the game build





HOW TO TEST THE FEATURES 



1. git clone the repo 
2. cd into the repo 
3. Open Unity Hub
4. Click Add > Add project from disk in Unity select the main project folder, and open it using the matching Unity Editor version.
5. Press Play
6. Observe the initial text displayed by ShowSavedData().
7. Click the button that triggers AddScore()
8. If The score increases and the text layout on the screen instantly reflects the new value.
9. While still in Play mode, click the rename button, enter a preferred name, save.
10. Press Stop to end the game simulation.
11. Press Play again to restart the game
12. If the changes made are still there then the test passed !!



