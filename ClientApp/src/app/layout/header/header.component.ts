import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  navMenu: boolean = false;

  toggleBurger() {
    this.navMenu = !this.navMenu;
  }

  constructor() {
 
   }

  resizeWindow(e) {
    if (e.target.innerWidth > 748 && this.navMenu == true) {
      this.toggleBurger();
    }
  }

  ngOnInit() {
    // var a = document.querySelector("nav span::before");
    // a.addEventListener("click", this.removeTask);
  }
}
