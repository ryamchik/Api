import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { RandomColorPipe } from 'src/pipes/randomColor.pipe';
import { ReversePipe } from 'src/pipes/reverse.pipe';

@NgModule({
  declarations: [
    AppComponent,
    RandomColorPipe,
    ReversePipe
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
