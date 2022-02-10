import { AccountService } from 'src/app/_services/account.service';
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoggedInGuard implements CanActivate {

  constructor(private accountService: AccountService, private routr: Router) {}

  canActivate() {
    return this.accountService.currentUser$.pipe(map(user => {
        if (user) {
          this.routr.navigateByUrl('/members');
          return false;
        }
        else return true;
      })
    );
  }

}
