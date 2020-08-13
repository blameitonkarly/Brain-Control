# Overview 

Open Program
  * Splash Screen
    * Request Access to Server
        * Login to Emotiv Account 
            * http://localhost:6868
            * Connect to Websocket
    * Request Access to App
      * Verify 
          * License: "8a3dbb42-47e9-470b-92b8-2a8ddd336291" (BCI API license key manually)
          * Client ID: 
          * Client Secret: 
      * Third Party Acceptance 
  * Constantly looking for connect to headset
  * Constantly telling if connect or not
  * Connect to Headset
      * Headset query
         * Refresh Headset
      * Connect Headset
      * Get Cortex Token
      * Create New Session
          * If Headset get disconnected
              * Lock out User from Software
              * Restart login process
      * Connect to EmotivBCI Training Profile
      
Main Screen


