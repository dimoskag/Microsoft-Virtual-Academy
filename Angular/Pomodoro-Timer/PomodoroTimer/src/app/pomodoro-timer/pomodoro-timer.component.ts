import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pomodoro-timer',
  templateUrl: './pomodoro-timer.component.html',
  styleUrls: ['./pomodoro-timer.component.css']
})
export class PomodoroTimerComponent implements OnInit {

  minutes: number;
  seconds: number;

  constructor() { 
    this.minutes = 24;
    this.seconds = 59;
    setInterval(() => this.tick(), 1000)
  }

  tick():void {
    if(--this.seconds < 0) {
      this.seconds = 59;
      if (--this.minutes < 0){
        this.minutes = 24;
        this.seconds = 59;
      }
    }
  }

  ngOnInit() {
  }

}
