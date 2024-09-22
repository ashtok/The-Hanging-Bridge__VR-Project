# The Hanging Bridge - VR Project

[![Watch the video](https://img.youtube.com/vi/YOUR_VIDEO_ID/0.jpg)](https://www.youtube.com/watch?v=YOUR_VIDEO_ID)

**Developed by:**  
Ashutosh Mahajan and Pallabi Pathak  
M.Sc. in Computer Science  
Julius-Maximilians-Universität Würzburg

## Project Overview
The Hanging Bridge is a Virtual Reality (VR) project designed to help individuals confront and overcome their fear of heights and falling. The project provides a controlled, immersive environment where participants can experience realistic scenarios that trigger these fears, with the goal of enhancing their mental resilience and ability to cope with similar challenges in real life.

## Inspiration
Many individuals experience anxiety related to heights, which can impact their daily lives emotionally and mentally. This project aims to address those fears through VR, offering a safe space for participants to gradually build their tolerance and focus in anxiety-inducing situations. By using immersive technology, the project helps individuals develop coping mechanisms that extend beyond the virtual environment into their everyday lives.

## Features
- **Realistic Virtual Environment:** Participants walk across a virtual bridge suspended over a river, providing a highly immersive experience that challenges their fear of heights.
- **3D Models:** All assets, including the bridge and wooden fence, are created using a modular approach in Blender 4.0, with materials applied in Unity.
- **Dynamic Difficulty:** Safe and unsafe bridge planks are positioned differently in each gameplay, providing varied challenges.
- **Player Interaction:** Players can interact with bridge planks to assess their safety and can explore the riverbank for more information about the bridge structure.
- **Soothing Environmental Audio:** Sounds like birds chirping and river flow are integrated to create a calming atmosphere and enhance immersion.

## Key Classes
- **BridgeHandler:** Manages the creation and destruction of the virtual bridge, using a pre-generated set of bridge templates.
- **GameManager:** Controls the game flow, including loading scenes, initiating timers, and handling player falls into the virtual river.
- **BridgePlank:** Stores information on each plank's condition and color-codes them to indicate safety.
- **UIManager:** Displays key data to the participants through the VR interface.

## Development Process
The development of the Hanging Bridge VR project emphasizes streamlined functionality. Every class and feature was thoughtfully designed to avoid redundancy while providing a smooth user experience. The system architecture is compartmentalized into distinct classes, each responsible for a specific domain.

3D models were created using Blender 4.0, ensuring high visual fidelity, while Unity was used for integrating and applying materials to these models. The immersive environment was carefully designed to maximize both participant comfort and engagement.

## Experimentation & Insights
A cohort of seven participants tested the application. They were monitored during gameplay, and feedback was gathered through a post-experience questionnaire to measure:

- Level of motion sickness
- Level of immersion
- Fear response while falling
- Difficulty crossing the bridge
- Overall performance improvement in successive attempts

## Key Findings
- **Exploration Patterns:** Participants initially explored their surroundings, with many inspecting the bridge structure before attempting to cross.
- **Bridge Crossing:** Success varied among participants, with some experiencing challenges during their first attempt. Repeated plays showed a noticeable learning curve, with participants improving their performance.
- **Environmental Feedback:** The calming audio and visually pleasing environment contributed positively to the overall experience.
- **Reduced Fear:** Participants demonstrated an improved ability to cope with their fear of falling over successive trials, highlighting the effectiveness of the experimental design.

## Conclusion
The Hanging Bridge VR project successfully provided participants with a controlled environment to confront their fear of falling. The results indicate a significant improvement in focus and resilience, affirming the potential of virtual reality as a tool for therapeutic experiences.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

