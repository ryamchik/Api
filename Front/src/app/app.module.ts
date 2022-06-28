import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { RainbowReverseComponent } from './rainbowReverse/rainbowReverse.component';
import { HttpClientModule } from '@angular/common/http'
import { RandomColorPipe } from 'src/pipes/randomColor.pipe';
import { ReversePipe } from 'src/pipes/reverse.pipe';

@NgModule({
  declarations: [
    AppComponent,
    RainbowReverseComponent,
    RandomColorPipe,
    ReversePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
