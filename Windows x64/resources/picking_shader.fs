#version 330

uniform vec3 ObjectPosition;

out vec4 FragColor;

void main()
{
   FragColor = vec4(ObjectPosition, 1.0);
}