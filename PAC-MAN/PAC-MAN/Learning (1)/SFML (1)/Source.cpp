#include <iostream>
#include <SFML\Graphics.hpp>
#include <SFML\Audio.hpp>
#include <SFML\Network.hpp>
#include <SFML\window.hpp>
#include "player.h"
using  namespace sf;

int main(){
	
	RenderWindow window ;
	window.create (sf::VideoMode(800,600),"Pac-Man" , sf::Style::Default );
	Texture playerTexture;
	playerTexture.loadFromFile("download - Copy.png");
	



	sf::RectangleShape map (sf::Vector2f(800.f,60.f));

	map.setPosition(0.f,0.f);
    

	sf::Texture mapUp ;	
	mapUp.loadFromFile("map1.PNG");
	map.setTexture(&mapUp);

	

	sf::RectangleShape map2 (sf::Vector2f(800.f,60.f));

	map.setPosition(0.f,550.f);
   

	sf::Texture mapDown ;	
	mapDown.loadFromFile("map2.PNG");
	map2.setTexture(&mapDown);



	sf::RectangleShape map3 (sf::Vector2f(60.f,800.f));

	map3.setPosition(0.f,0.f);
    

	sf::Texture mapLeft ;	
	mapLeft.loadFromFile("map3.PNG");
	map3.setTexture(&mapLeft);



	
	sf::RectangleShape map4 (sf::Vector2f(60.f,800.f));

	map4.setPosition(750.f,0.f);
    

	sf::Texture mapRight ;	
	mapRight.loadFromFile("map4.PNG");
	map4.setTexture(&mapRight);




	sf::RectangleShape photo (sf::Vector2f(150.f,200.f));

	photo.setPosition(320.f,290.f);
    

	sf::Texture photo1 ;	
	photo1.loadFromFile("map5.PNG");
	photo.setTexture(&photo1);
	
	player player(&playerTexture,sf::Vector2u(9,4),0.1f,100.0f);

	float deltaTime=0.0f;
	sf::Clock clock;
	
    


	while (window.isOpen()){
		deltaTime = clock.restart().asSeconds();
		Event Event ;
		while (window.pollEvent(Event)){
		

			if (Event.type==sf::Event::Closed){

				window.close();
				break;
			}
		
		}
		
		
		

		player.Update(deltaTime);
		window.clear(sf::Color::Black);
		window.draw(map);
		window.draw(map2);
		window.draw(map3);
		window.draw(map4);
		window.draw(photo);
		player.Draw(window);
		window.display();
		

	
		

	}



	return 0 ;
}