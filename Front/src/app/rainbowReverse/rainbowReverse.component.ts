import { Component } from '@angular/core';
import { NgModule } from '@angular/core';

@Component({
  selector: 'rainbow',
  templateUrl: './rainbowReverse.component.html'
})
export class RainbowReverseComponent {
  public inputString!: string;
  public letterColor!: string;
}
