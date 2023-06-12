#include "player.h"


player::player(sf::Texture* texture,sf::Vector2u imageCount,float switchTime,float speed):
	animation(texture,imageCount,switchTime)
{
	this->speed=speed;
	row = 0;
	faceRight = true;
	bofy.setSize(sf::Vector2f(50.0f,60.0f));
	bofy.setPosition(70.0f,70.0f);
	bofy.setTexture(texture);
}


player::~player()
{
}

void player::Update(float deltaTime){
	sf::Vector2f movement(0.0f,0.0f);
	if(sf::Keyboard::isKeyPressed(sf::Keyboard::A)){
		movement.x -= speed * deltaTime;
	}
	if(sf::Keyboard::isKeyPressed(sf::Keyboard::D)){
		movement.x += speed * deltaTime;
	}
	if(sf::Keyboard::isKeyPressed(sf::Keyboard::W)){
		movement.y -= speed * deltaTime;
	}
	if(sf::Keyboard::isKeyPressed(sf::Keyboard::S)){
		movement.y += speed * deltaTime;
		
	}
	if(movement.x == 0.0f){
		row=0;
	}
	else{
		row=1;
		if(movement.x>0.0f){
			faceRight = false;
		}
		else{
		    faceRight = true;
		}
	}
	animation.Update(row,deltaTime,faceRight);
	bofy.setTextureRect(animation.uvRect);
	bofy.move(movement);
}
void player::Draw(sf::RenderWindow& window){
	window.draw(bofy);
}
