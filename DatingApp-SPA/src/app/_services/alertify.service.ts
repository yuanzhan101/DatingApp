import { Injectable } from '@angular/core';
import * as alertify from 'alertifyjs';

@Injectable()
export class AlertifyService {

constructor() { }

    confirm(message: string, okCallback:() => any) {
        alertify.confirm(message, (e:any) => {
            if (e) {
                okCallback();
            } else {}
        });
    }

    successs(message: string) {
        alertify.successs(message);
    }

    error(message: string) {
        alertify.error(message);
    }

    warning(message: string) {
        alertify.warning(message);
    }

    message(message: string) {
        alertify.message(message);
    }
}
