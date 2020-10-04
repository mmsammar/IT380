using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public TMP_Text introText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                IntroInit();
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }

    void IntroInit()
    {
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "Welcome to Learning ROCKS!\n\n" +
            "Learn about rocks and minerals by becoming a mining master!";
        introImage.SetActive(true);
        backButton.SetActive(false);
    }

    public void IntroSequenceBack()
    {
        introSequence --;
        SetIntroSequence();
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        SetIntroSequence();
    }

    void SetIntroSequence()
    {
        switch (introSequence)
        {
            case 0:
                IntroInit();
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW\n\n" +
                    "Title: Learning ROCKS!\n" +
                    "Platform: WebGL Build\n" +
                    "Subject: Earth Science\n" +
                    "Sub Subject: Geology\n" +
                    "Main Focus: Rocks and Minerals\n" +
                    "Learning Level: Grades 6-8";
                break;
            case 2:
                introText.text = "PROPOSED EDTECH SOLUTION\n\n" +
                    "Earth science and geology are very important fields of study, as they directly concern the planet that sustains human life and all life, and encompass all the things that make up the physical world around us. It can be difficult, however, for students to engage in learning about rocks and minerals, as it is often not as easy to make exciting and engaging to help them retain the information.  I propose a solution in the form of an interactive game where users perform the role of miners! They will engage in fun mini-games/activities to mine minerals, learn about what they pick up, amass collections, and progress through guided activities/level up on their quests to be master miners!  Students will be able to learn detailed information on the minerals they collect, look back on the information they’ve collected later on, and they'll have to perform learning activities to reinforce the info and level up, enabling them to mine more difficult to attain resources in an attempt to become the number one miner in history!";
                break;
            case 3:
                introText.text = "COMPETING SOFTWARE REVIEW\n\n" +
                    "Mineralogy4Kids - Educational resource geared towards students around the middle school age range to teach them about rocks, minerals, rock cycles, and other geological information. This resource is offered by the Mineralogical Society of America, which for over 100 years has been offering educational resources and disseminating research and information through its members. The site offers multiple interactive web pages describing different geological phenomena, including a webpage with games regarding geology, however many of them are external links and some no longer work.\n" +
                    "LayeredEarth - Commercial classroom solution for geological simulation, with its own geological curriculum. I was unable to attain a license for this software in order to test it out, but they offered detailed information, graphics, screenshots, examples, etc. through their website. The program offers relatively easy to navigate but comprehensive simulations of different geological processes, interactive maps and activities, and guided lessons and activities geared towards middle and high school classroom education environments.\n" +
                    "Legends of Learning - Legends of Learning is a platform with thousands of interactive educational games for use in classroom environments, with different educational packages available for purchase. Legends of Learning offers a suite of games geared towards Geology/Fossils. While the full package requires purchase, they offer demos of the games that can be played within the browser. Multiple demos I couldn't get to work, but the one I did, Fossil Hunt was relatively simple to use, intuitive, and offered educational descriptions in conjunction with gameplay, however it was also repetitive, overloaded information, and UI and mechanics could've been made smoother.";
                break;
            case 4:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS\n\n" +
                    "Gameification/Engagement- Want to develop well-defined structured gameplay where users must go about finding, collecting, organizing, learning about minerals. Users will get guided objectives, effective tutorialization and introduction to topic and mechanics. There will efficient information dissemination (finding a way not to overwhelm user with info, such as short descriptions when they pick up minerals and longer information available in a library or something similar), and collectibles/achievements/levels or some other engaging incentive.\n\n" +
                    "Graphics/Interactivity- UI system will be intuitive and graphically appealing (such as simple, easy to interpret symbols and simple, uncluttered UI features for ease of navigation). Game graphics should be simple but endearing, allowing the users to get engaged in the game and attached to their mining character and the mission of becoming a mining master. Mechanics should be smooth and simple, allowing users to progress through game without frustration, with the emphasis placed on the difficulty of the learning tasks rather than the game itself being overly difficult/frustrating.\n\n" +
                    "Accessibility - these platforms are restrictive in terms of platform and availability, as they are only present on PC. Increasing accessibility by expanding to multiple possible platforms of access (i.e. accessing WebGL build from computer, laptop, tablet, phone, etc.) opens the project up to more potential users and offers greater possibility for usage time and engagement, which will allow it to be a more effective tool.";
                break;
            case 5:
                introText.text = "STAKEHOLDERS\n\n" +
                    "Educators and Course Instructors/Coordinators\n" +
                    "Parents\n" +
                    "Students\n\n" +
                    "USERS\n\n" +
                    "Students: 6-8th grade middle school";
                break;
            case 6:
                introText.text = "PERSONA\n\n" +
                    "Name: Shana\n" +
                    "Age: 12 years old\n" +
                    "Gender: Female\n" +
                    "Location: StockInnerCity/UrbanArea USA\n" +
                    "Personal Notes:\n" +
                    "     Enjoys math and science and reading\n" +
                    "     Likes to be outside and observe nature, despite being from the city\n" +
                    "     Likes to play fun, simple computer games online\n" +
                    "Student Notes:\n" +
                    "     Struggles to focus and maintain attention in class setting\n" +
                    "     Benefits more from hands-on applied learning\n" +
                    "     Not attuned to rote memorization or lecture learning\n" +
                    "     Tends to daze off unless engaged in class by video/movie/etc.";
                break;
            case 7:
                introText.text = "PERSONA JUSTIFICATION\n\n" +
                    "After researching and gathering information for this initial phase of development, I settled on a persona named Shana. Shana represents the ideal user for my proposed edtech solution, a middle school student bustling with creativity who struggles with traditional learning and might thrive in an unorthodox approach to learning that’s more engaging and appeals to the subjects they’re into, in this case a field of science. I chose this persona because middle school is a formative time where many students will discover fields of interest that influence their development.";
                break;
            case 8:
                introText.text = "PROBLEM SCENARIO\n\n" +
                    "School has always been an issue for Shana, who struggles with focusing and maintaining attention during lessons and lectures, but mid-pandemic learning has amplified those difficulties for Shana immensely. She loves math and science, and thrives when she’s in her own world and able to read as she desires, and her 7th grade science teacher has always noticed her ability and been considerate of her struggles as a result. As schools shift back and Shana finds herself in school only two days a week, her science class shifts to a unit on earth science, which Shana loves as she is fond of nature in general, but the three days she has to join class from home exacerbate Shana’s struggles, as she gets easily distracted and can’t focus.\n\n" +
                    "On one instance her teacher sees her looking away from the webcam and laughing while instruction is going on, so he asks Shana what she’s doing. As it turns out, Shana was playing a game on her Nintendo Switch rather than focusing on the lecture. After a short reprimand from the teacher, Shana tries to focus on the lecture again but can’t draw her attention back in, resulting in a very low grade on the first quiz she takes in her Earth Science unit, disappointing herself, her parents, and her teacher.";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO\n\n" +
                    "Following introductory units to things such as biomes and ecosystems, water/hydrogen/natural cycles, etc., Shana’s class moves into the topic of rocks and minerals. Shana worries that she’ll do even worse than before as how could she ever find a way to focus on ROCKS and find them interesting? However, to her surprise, when she walks into the school for the first day of that week, her instructor presents to the class a new style of learning they’ll be conducting for this unit. She instructs them to head to a link, which opens up to a game called “Learning ROCKS!”, a fantastically incredible and well-built game to teach about rocks and minerals by becoming a miner! Once she goes through the intro and gets an idea for what she’ll be doing, Shana becomes excited by the prospect of playing games like she loves to do at home and learning about scientific concepts she enjoys learning but struggles focusing on.";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.text = "ACTIVITY SCENARIO CONTINUED\n\n" +
                    "After playing through the game for a while, Shana progresses through, levelling up, gaining access to more resources, and every time she mines a new mineral she learns many different important facts and details about it, such as different properties of the mineral, methods for identification, and other classifications of minerals, etc. She learns basics about different properties of rocks and minerals, common usages and purposes of certain minerals in real life, and goes through learning tasks to identify minerals, classify them, answer questions, and more. She also has access to a store of knowledge on minerals that can grow as she progresses through the game. When it came time for her unit assessment, Shana passed with flying colors, delighting herself, her parents, and her teacher.";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "PROBLEM STATEMENT\n\n" +
                    "Shana struggles with the monotonous, repetitive nature of her classes and lesson structures. She likes to be active and constantly engaged in activity, and she responds well to doing something and seeing the results of her actions in front of her. She enjoys the sciences and loves nature, and she doesn’t find the concepts boring, but she just can’t find a way to engage with traditional learning. She needs a way to connect with the material she’s learning and not be held back by her difficulties attuning with learning methods that aren’t suited for her, to understand the principles behind the concepts she struggles with and develop her interests that may carry her into adulthood. She learns important information about rocks and minerals as she engages in fun games and learning activities, that help ground the concrete knowledge in her mind which she can then apply later.";
                break;
        }
    }
}
