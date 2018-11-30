import { Component } from '@angular/core';
// import { ActivatedRoute, Router, ChildActivationEnd } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  // route: ActivatedRoute;
  // hideSidebar: any;

  constructor(){
  //   private router: Router
  // ) {
  //   // console.log("is root", route == route.root);
    
  //   // this.route = route.firstChild;
  // }

  // ngOnInit(): void {
  //   this.router.events
  //     .subscribe(event => {
  //       let snapshotEvent: ChildActivationEnd = event as ChildActivationEnd;
  //       if (snapshotEvent.snapshot) {
  //         let snapshot = snapshotEvent.snapshot;
  //         console.log(snapshot);
  //         if (snapshot.component) {
  //           this.hideSidebar = snapshot.data.hideSidebar;
  //         }
  //       }
  //     });
  //   // this.route.url.subscribe(url => {
  //   //   console.log("config", this.route);
  //   //   console.log("url", url);
  //   // })
  }

}
