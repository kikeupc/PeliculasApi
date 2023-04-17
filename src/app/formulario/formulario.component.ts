import { Component, ElementRef, ViewChild } from '@angular/core';
import { LogginService } from '../LogginService.service';
import { Persona } from '../persona.model';
import { PersonasService } from '../personas.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']  
})
export class FormularioComponent {

   
  nombreInput:string = '';
  apellidoInput:string = '';
  

  constructor(private logginService:LogginService,
              private personasService:PersonasService){
                  this.personasService.saludar.subscribe(
                    (indice:number) => alert("El indice es: " + indice)
                  );
               }

  agregarPersona(){
    let persona1 = new Persona(
      this.nombreInput, this.apellidoInput); 
    //this.logginService.enviaMensajeAConsola("Enviamos persona con nombre: " + persona1.nombre + " apellido: " + persona1.apellido);     
    //this.personaCreada.emit(persona1);
    this.personasService.agregarPersona(persona1);
  }
}
