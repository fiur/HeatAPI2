import { Component, Fragment } from 'react';
import { Link, BrowserRouter, Route, Switch, StaticRouter, Redirect, } from 'react-router-dom';
import { Helmet } from 'react-helmet';
import { CommentsBox } from './comments/Sample.jsx';

class Navbar extends Component {
	render() {
		return (
			<ul>
				<li>
					<Link to="/">Dette er en Test</Link>
				</li>
				<li>
					<Link to="/comments">Comments Demo</Link>
				</li>
			</ul>
		);
	}
}

class HomePage extends Component {
	render() {
		return (
			<Fragment>
				<Helmet>
					<title>ReactJS.NET Demos</title>
				</Helmet>
			</Fragment>
		);
	}
}


export default class HomeComponent extends Component {

	tick() {
		console.log("Nu er der gået et sekund");
	}

	componentDidMount() {
		this.interval = setInterval(() => this.tick(), 1000);
	}

	componentWillUnmount() {
		clearInterval(this.interval);
	}

	render() {
		const app = (
			<div className="container">
				<div className="jumbotron">
					<h1 className="display-4">bygget ved hjælp af React og .NET Core Sample</h1>
					<Navbar />
					<hr className="my-4" />
					<Switch>
						<Route
							exact
							path="/"
							render={() => <Redirect to="/comments" />}
						/>
						<Route path="/home" component={HomePage} />
						<Route
							path="/comments"
							component={() => (
								<CommentsBox
									initialComments={this.props.initialComments}
									page={this.props.page}
								/>
							)}
						/>
						<Route
							path="*"
							component={({ staticContext }) => {
								if (staticContext) staticContext.status = 404;

								return <h1>Not Found :(</h1>;
							}}
						/>
					</Switch>
				</div>
			</div>
		);

		if (typeof window === 'undefined') {
			return (
				<StaticRouter
					context={this.props.context}
					location={this.props.location}
				>
					{app}
				</StaticRouter>
			);
		}
		return <BrowserRouter>{app}</BrowserRouter>;
	}
}
