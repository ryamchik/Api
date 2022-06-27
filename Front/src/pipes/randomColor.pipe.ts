import { Pipe, PipeTransform } from '@angular/core';
  
@Pipe({
    name: 'randomColor'
})
export class RandomColorPipe implements PipeTransform {
  transform(value: string): string {
    return '#' +(0x1000000+Math.random()*0xffffff).toString(16).substr(1,6);
  }
}