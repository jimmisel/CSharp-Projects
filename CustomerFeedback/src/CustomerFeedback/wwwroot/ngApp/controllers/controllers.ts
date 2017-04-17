namespace CustomerFeedback.Controllers {

    export class HomeController {
        public feedBack;

     
        constructor(feedbackService: CustomerFeedback.Services.FeedbackService) {
            this.feedBack = feedbackService.listFeedback();
        }
    }
    export class AddController {
        public feedbackToAdd;
       

        addFeedback() {
            this.feedbackService.save(this.feedbackToAdd).then(
                () => this.$state.go('home')
            );
        }

        constructor(private feedbackService: CustomerFeedback.Services.FeedbackService, private $state: ng.ui.IStateService) { }
    }
    export class DeleteController {
        public feedback;

        delete() {
            
            this.feedbackService.deleteFeedBack(this.feedback.id).then(
                () => this.$state.go('home')
            )
        }

        constructor(private feedbackService: CustomerFeedback.Services.FeedbackService, private $state: ng.ui.IStateService,private $stateParams: ng.ui.IStateParamsService) {
            this.feedback = feedbackService.getFeedBack($stateParams['id'])
        }
    }

    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
