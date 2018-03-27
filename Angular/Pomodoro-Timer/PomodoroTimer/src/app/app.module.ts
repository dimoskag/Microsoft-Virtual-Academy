import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { PomodoroTimerComponent } from './pomodoro-timer/pomodoro-timer.component';


@NgModule({
  declarations: [
    AppComponent,
    PomodoroTimerComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent, PomodoroTimerComponent]
})
export class AppModule { }
